using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatBD
{
    internal class InformationAboutTheBreed
    {
        public int Id { get; set; }
        
       
        public string? CountryOfOrigin { get; set; }
        public string? LifeExpectancy { get; set; }
        public string? Size { get; set; }
        public double Weight_kg { get; set; }
        public string? CoatType { get; set; }
        public string? Color { get; set; }
        public string? Lifestyle { get; set; }
        public string? Group { get; set; }
        public string? Price { get; set; }
        public int? FamylyId { get; set; }
        public Famyly? famyly { get; set; }
        public override string ToString()
        {
            return
                $"Id:{Id}\n" +
                $"Страна происхождения: {CountryOfOrigin}\n" +
                $"Продолжительность жизни: {LifeExpectancy}\n" +
                $"Размер: {Size}\n" +
                $"Масса: {Weight_kg} \n" +
                $"Тип шерсти: {CoatType} \n" +
                $"Окрас: {Color}" +
                $"Образ жизни: {Lifestyle} \n" +
                $"Группа: {Group}  \n" +
                $"Цена: {Price}  \n" ;
        }
    }
}
