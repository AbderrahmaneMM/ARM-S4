using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMVV.Models
{ 
    public class Perssone 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prénom { get; set; }
    }
    public class Model01
    {
        public Perssone[] perssones {  get; set; }
        public Model01() 
        {
          perssones = new Perssone[]
          {
            new Perssone() {Id=1,Name="Bennoui" ,Prénom="Sami"},
            new Perssone() {Id=2,Name="BouAbdellah" ,Prénom="Hamid"},
            new Perssone() {Id=3,Name="BenYahiya" ,Prénom="Raouf"}
          };
        }
    }
   
}