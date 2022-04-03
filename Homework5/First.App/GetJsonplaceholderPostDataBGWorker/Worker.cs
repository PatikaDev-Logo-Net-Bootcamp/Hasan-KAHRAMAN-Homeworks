using First.App.Business.Abstract;
using First.App.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GetJsonplaceholderPostDataBGWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient httpClient;
        //private readonly IPostService _postService;
        private readonly IServiceScopeFactory _service;

        public Worker(ILogger<Worker> logger, IServiceScopeFactory service)
        {
            _logger = logger;
            //_postService = postService;
            _service = service;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            httpClient = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            httpClient.Dispose();
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var request = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                
                if (request.IsSuccessStatusCode)
                {
                    var response = await request.Content.ReadAsStringAsync();
                    
                    var posts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(response);

                    using (var scope = _service.CreateScope())
                    {
                        var myScopedService = scope.ServiceProvider.GetRequiredService<IPostService>();
                        myScopedService.AddPosts(posts);
                    }
                    
                }
                else
                {
                    _logger.LogError("Error while getting data from jsonplaceholder.typicode.com/posts");
                } 
                await Task.Delay(60000, stoppingToken);
                
            }
        }
    }
}
