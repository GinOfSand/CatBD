using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatBD
{
    internal class Famyly
    {
        [NotNull]
        public int Id { get; set; }
        public string? FamylyName { get; set; }
        public ICollection <BreedCharacteristics>? Characteristic { get; set; } = null!;
        public ICollection <InformationAboutTheBreed>? Information { get; set; } = null!;
        //public Famyly(string fn)
        //    { FamylyName = fn; }
        public override string ToString()
        {
            return $"Id:{Id} Порода:{FamylyName}";
        }
    }
}
