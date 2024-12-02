using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApuntesGomezcoelloJustin.Models
{
    internal class About
    {
        public string Title => "Justin Gomezcoello";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Soy un chico de 20 años que le encanta pasar horas y horas en la pc investigando nuevos temas de mi interés, al igual que me gusta mucho jugar fútbol y ir al gimnasio ya que esto me desestresa. ";
        public string Icon { get; set; }
    
    }
}
