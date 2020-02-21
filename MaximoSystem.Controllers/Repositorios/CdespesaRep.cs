using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;
using MaximoSystem.Controllers.Context;

namespace MaximoSystem.Controllers.Repositorios
{
    public class CdespesaRep
    {
        public void Cadastrar(Cdespesa obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Cdespesa.Add(obj);
                ctx.SaveChanges(); //SALVA NO BANCO DE DADOS
            }
        }

        public Cdespesa Buscar(int id)
        {
            Cdespesa obj = new Cdespesa();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Cdespesa.Find(id); //METODO DE BUSCAR COM BASE NO PARAMETRO ID
            }
            return obj;
        }

        public List<Cdespesa> listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Cdespesa = (from obj in ctx.Cdespesa select obj).OrderBy(x => x.Cd_cdespesa).ToList(); //BUSCA TODOS OS REGISTROS E RETORNA EM UMA LISTA
                return Cdespesa;
            }

        }

        public void Deletar(Cdespesa obj)
        {
            using (var ctx = new SistemaContext())
            {


                ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();

                //Ccusto obj = ctx.Ccusto.Find(id); //LOCALIZA O ID PARA A DELECAO    
                //ctx.Ccusto.Remove(obj); // DELETA O REGISTRO
                //ctx.SaveChanges();

            }
        }

        public void Modificar(Cdespesa obj)
        {
            using (var ctx = new SistemaContext()) //PASSA OS DADOS DA OBJETO ANTIGO PARA O OBJETO NOVO E ATUALIZA NO BANCO
            {
                ctx.Cdespesa.Attach(obj);
                ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

                //Ccusto objOld = ctx.Ccusto.SingleOrDefault(x => x.Id_cc == objNew.Id_cc);
                //objOld.Cd_custo = objNew.Cd_custo;
                //objOld.De_custo = objNew.De_custo;
                //objOld.Fg_ativo = objNew.Fg_ativo;
                //ctx.SaveChanges(); //SALVA AS ALTERACOES
            }
        }
    }

}