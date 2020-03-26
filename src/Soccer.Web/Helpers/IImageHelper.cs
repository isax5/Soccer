using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Soccer.Web.Helpers
{
    public interface IImageHelper
    {
        /// <summary>
        /// Save image
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="folder"></param>
        /// <returns>File name</returns>
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }

}
