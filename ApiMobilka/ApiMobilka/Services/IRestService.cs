using System;
using System.Collections.Generic;
using System.Text;
using ApiMobilka.Models;
using System.Threading.Tasks;

namespace ApiMobilka.Services
{
    public interface IRestService
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
