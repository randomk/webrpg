using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using rpg.Models;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace rpg.Dao
{
    public class AtributoDao
    {
        public List<Atributos> Listar_Atributos_dt()
        {
            Conexao _conn = new Conexao();
            List<Atributos> list_Atributo = new List<Atributos>();

            DataTable dt_Atributo = _conn.dataTable("select * from Atributos where ativo = 1", "ATRIBUTOS");
            foreach (DataRow row in dt_Atributo.Rows)
            {
                list_Atributo.Add(new Atributos
                {
                    Cod_Atributo = Convert.ToInt32(row["cod_atributo"].ToString()),
                    Descricao = row["descricao"].ToString(),
                    Ativo = Convert.ToBoolean(row["ativo"].ToString())
                });
            }

            return list_Atributo;
        }

    }
}
