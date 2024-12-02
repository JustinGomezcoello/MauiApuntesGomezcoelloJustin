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
        public string Message => "Soy un chico de 20 años que le encanta pasar horas y horas en la pc investigando nuevos temas de su interés, al igual que le gusta mucho jugar fútbol y ir al gimnasio.";
        public string Icon { get; set; }
    
    }
}
