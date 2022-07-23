using Microsoft.AspNetCore.Http;

namespace BackEndKino.Services
{
    public class DownloadService : IUpload
    {
        public async void Upload(IFormCollection IFF)
        {
            var file = IFF.Files[0];

            string filePut = @$"D:\C#\BackEndKino\wwwroot\resources\images\{file.FileName}";

            using (var stream = System.IO.File.Create(filePut))
            {
                await file.CopyToAsync(stream);
            }

        }
    }
}
