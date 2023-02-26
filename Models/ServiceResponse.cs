<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

=======
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
<<<<<<< HEAD
        public string Message { get; set; } = string.Empty;
=======
        public string Message { get; set; }= string.Empty;   
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    }
}