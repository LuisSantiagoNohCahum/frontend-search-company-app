using System.Text.Json;

namespace frontend_app.ApiHelpers
{
    public class RestClient
    {
        public static async Task<RestResponse<T>> GetByRfc<T>(string url) where T:class{
            RestResponse<T> restResponse = new (){
                Data = default,
                Success = false
            };

            try
            {
                using HttpClient httpClient = new();
                var json = await httpClient.GetStringAsync(url);
                if (json is not null)
                {
                    /* restResponse.Data = JsonSerializer.Deserialize<IEnumerable<T>>(json); */
                    restResponse.Data = JsonSerializer.Deserialize<T>(json);
                    restResponse.Success = true;
                }
            }
            catch (System.Exception)
            {
                /* throw; */
            }

            return restResponse;
        }
    }
}