using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Wiz.Template.API.ViewModels.Customer
{
    public class CustomerIdViewModel
    {
        public CustomerIdViewModel()
        {

        }
        public CustomerIdViewModel(int id)
        {
            Id = id;
        }

        [FromRoute(Name = "id")]
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }
    }
}