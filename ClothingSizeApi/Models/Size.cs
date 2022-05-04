using System;
//using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ClothingSizeApi.Models
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Brand { get; set; }
        public string ClothingType { get; set; }
        public string Gender { get; set; }
        public string LetterSize { get; set; }
        [Range(0, 30, ErrorMessage = "Neck must be between 0 and 30.")]
        public Double Neck  { get; set; }
        [Range(0, 80, ErrorMessage = "Chest must be between 0 and 80.")]
        public int Chest { get; set; }
        [Range(0, 50, ErrorMessage = "Sleeve must be between 0 and 50.")]
        public int Sleeve { get; set; }
        [Range(0, 60, ErrorMessage = "Waist must be between 0 and 60.")]
        public int Waist { get; set; }
        [Range(0, 100, ErrorMessage = "Hip must be between 0 and 100.")]
        public int Hip { get; set; }
        [Range(0, 50, ErrorMessage = "Inseam must be between 0 and 50.")]
        public int Inseam { get; set; }
    }
}

