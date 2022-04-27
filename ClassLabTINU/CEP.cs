using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabTINU
{
    public class CEP
    {
        //Váriaveis
        string _uf;
        string _localidade;
        string _bairro;      
        string _logradouro;
      

        public string UF
        {
            get { return _uf; }
        }
        public string Cidade
        {
            get { return _localidade; }
        }
        public string Bairro
        {
            get { return _bairro; }
        }             
        public string Logradouro
        {
            get { return _logradouro; }
        }

        

        //Regiao construtor
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public CEP(string CEP)
        {
            _uf = "";
            _localidade = "";
            _bairro = "";           
            _logradouro = "";
           

            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("https://viacep.com.br/ws/" + CEP.Replace("-", "").Trim() + "/xml");
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _localidade = ds.Tables[0].Rows[0]["localidade"].ToString().Trim();
                            _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            _logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                           
                }
            }



        }
    }




}
