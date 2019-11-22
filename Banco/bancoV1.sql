--************************************************
-- Sistema ........: MAXIMOSYSTEM
-- Objeto de Banco.: Script
-- Objetivo........: Criar tabelas
-- Data criação....: 21/11/2019 Versão: V1
-- Revisão ........: 22/11/2019	
-- Obs.............: Corrigido problema com FK da tabela HIST_PRESTA_CONTAS.
--************************************************

---------------CRIAR_BASE_DADOS------------------

CREATE DATABASE maximosystem
GO

USE maximosystem
GO

-------------TABELAS_FLUXO_CAIXA-----------------

create table USUARIOS (
	ID_USER int IDENTITY(1,1) NOT NULL,
	NOME 	varchar(20) NOT NULL,
	USUARIO varchar(15) NOT NULL, 
	SENHA 	varchar(15) NOT NULL
	
	PRIMARY KEY (ID_USER, USUARIO)
	
)

--------------------------------------------------

create table CCUSTOS (
	ID_CC 		int IDENTITY(1,1) NOT NULL,
	CD_CCUSTO	numeric(15) NOT NULL,
	DE_CUSTO 	varchar(20) NOT NULL,	
	
	PRIMARY KEY (ID_CC, CD_CCUSTO)
	
)

--------------------------------------------------

create table CDESPESAS (
	ID_CDES 	int IDENTITY(1,1) NOT NULL,
	CD_CDESPESA numeric(15) NOT NULL, 
	DE_CDESPESA varchar(20) NOT NULL,
	
	PRIMARY KEY (ID_CDES, CD_CDESPESA)

)

--------------------------------------------------

create table FUNCIONARIOS (
	ID_FUNC 	int IDENTITY(1,1) NOT NULL,
	CD_FUNC		numeric(8) NOT NULL,
	DE_FUNC		varchar(30) NOT NULL, 
	FG_ATIVO	char NOT NULL CHECK (FG_ATIVO IN ('V', 'D')),  -- V = ATIVO, D = DEMITIDO
	
	PRIMARY KEY (ID_FUNC, CD_FUNC)
	
)

--------------------------------------------------

create table FLUXO_CAIXA (
	ID_FLCA 	 int IDENTITY(1,1) NOT NULL, 
	DT_MOVIMENTO date	NOT NULL, 
	ID_FUNC		 int,
	CD_FUNC      numeric(8),
	DE_OPERACAO  varchar(255) NOT NULL, 
	VALOR		 decimal(5,2) NOT NULL,
	TP_OPER		 char NOT NULL CHECK (TP_OPER IN ('E', 'S')),  -- E = ENTRADA, S = SAIDA

	CONSTRAINT fk_FuncCaixa FOREIGN KEY (ID_FUNC, CD_FUNC) REFERENCES FUNCIONARIOS (ID_FUNC, CD_FUNC), 
	PRIMARY KEY (ID_FLCA)	

)

--------------------------------------------------

create table PRESTA_CONTAS (
	ID_PRE_CON		int IDENTITY(1,1) NOT NULL,
	DT_MOVIMENTO	date NOT NULL,
	ID_CC			int,
	CD_CCUSTO		numeric(15),
	ID_CDES			int,
	CD_CDESPESA		numeric(15),	
	VL_SAIDA		decimal(5,2) NOT NULL,
	FG_DISPONIVEL	char(3) NOT NULL CHECK (FG_DISPONIVEL IN ('SIM', 'NAO')),

	CONSTRAINT fk_CcContas   FOREIGN KEY (ID_CC, CD_CCUSTO) REFERENCES CCUSTOS (ID_CC, CD_CCUSTO),
	CONSTRAINT fk_CdesContas FOREIGN KEY (ID_CDES, CD_CDESPESA) REFERENCES CDESPESAS (ID_CDES, CD_CDESPESA),
	PRIMARY KEY (ID_PRE_CON)	

)

--------------------------------------------------

create table HIST_PRESTA_CONTAS (
	ID_HIS_PRE_CON	  int IDENTITY (1,1) NOT NULL,
	ID_CC			  int,
	CD_CCUSTO		  numeric(15),
	ID_CDES			  int,
	CD_CDESPESA		  numeric(15),
	DE_PRESTACAO	  varchar(255),
	DT_PROCESSAMENTO  date NOT NULL,	
	VALOR 			  decimal(5,2) NOT NULL,

	CONSTRAINT fk_CcHisContas   FOREIGN KEY (ID_CC, CD_CCUSTO) REFERENCES CCUSTOS (ID_CC, CD_CCUSTO),
	CONSTRAINT fk_CdesHisContas FOREIGN KEY (ID_CDES, CD_CDESPESA) REFERENCES CDESPESAS (ID_CDES, CD_CDESPESA),
	PRIMARY KEY (ID_HIS_PRE_CON)
	
)