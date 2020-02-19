using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximoSystem.Entidades;
using MaximoSystem.Controllers.Context;

namespace MaximoSystem.Controllers.Repositorios
{
    public class CcustoRep
    {
        public void Cadastrar (Ccusto obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Ccusto.Add(obj);
                ctx.SaveChanges(); //SALVA NO BANCO DE DADOS
            }
        }

        public Ccusto Buscar(int id)
        {
            Ccusto obj = new Ccusto();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Ccusto.Find(id); //METODO DE BUSCAR COM BASE NO PARAMETRO ID
            }
            return obj;
        }

        public List<Ccusto> listar()
        {
            
            using (var ctx = new SistemaContext())
            {
                var Ccusto = (from obj in ctx.Ccusto select obj).OrderBy(x => x.Cd_custo).ToList(); //BUSCA TODOS OS REGISTROS E RETORNA EM UMA LISTA
                return Ccusto;
            }
   
        }

        public void Deletar(Ccusto obj)
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

        public void Modificar(Ccusto obj)
        {
            using (var ctx = new SistemaContext()) //PASSA OS DADOS DA OBJETO ANTIGO PARA O OBJETO NOVO E ATUALIZA NO BANCO
            {
                ctx.Ccusto.Attach(obj);
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
