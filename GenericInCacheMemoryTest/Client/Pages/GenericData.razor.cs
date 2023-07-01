using GenericInCacheMemoryTest.Shared;
using System.Net.Http.Json;
using System.Web;

namespace GenericInCacheMemoryTest.Client.Pages
{
    public partial class GenericData
    {
        public IEnumerable<GenericClass> genericList { get; set; }

        

        protected override async Task OnInitializedAsync()
        {
            await GetGenericCacheList();
        }

        private async Task GetGenericCacheList()
        {
            genericList = await Http.GetFromJsonAsync<IEnumerable<GenericClass>>("api/GenericClass");
        }
    }
}
