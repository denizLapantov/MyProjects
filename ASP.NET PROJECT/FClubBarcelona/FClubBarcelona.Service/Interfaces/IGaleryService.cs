namespace FClubBarcelona.Service.Interfaces
{
    using System.Collections.Generic;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Video;

    public interface IGaleryService
    {
        void AddPIcture(GaleryViewModel model);
        void AddVideo(VideoVm model);
        void Delete(int? id);
        GaleryViewModel DeletePicture(int? id);
        void DeleteVid(int? id);
        VideoVm DeleteVideo(int? id);
        void EditPic(GaleryViewModel pictureVm);
        GaleryViewModel EditPicture(int? id);
        void EditVid(VideoVm videoVm);
        VideoVm EditVideo(int? id);
        IEnumerable<GaleryViewModel> GetAllPictures();
        IEnumerable<VideoVm> GetAllVideos();
    }
}