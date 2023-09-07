using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Ex2.Models
{
    public class Autovehicul
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string SerieSasiu { get; set; }
        public int AnFabricatie { get; set; }
        public Producator Producator { get; set; }

        public override string ToString() => $"{Id} | {Model} | {AnFabricatie} | {Producator}";
    }
}
