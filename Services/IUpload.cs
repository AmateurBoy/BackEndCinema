using Microsoft.AspNetCore.Http;

namespace BackEndKino.Services
{
    public interface IUpload
    {
        public void Upload(IFormCollection IFF);
    }
}
