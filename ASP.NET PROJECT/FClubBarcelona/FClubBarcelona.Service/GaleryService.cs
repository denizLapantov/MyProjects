namespace FClubBarcelona.Service
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using AutoMapper;
    using Models.IdentityModels;
    using Models.ViewModels.Galery;
    using Models.ViewModels.Video;
    using Interfaces;

    public class GaleryService : Service, IGaleryService
    {
        public IEnumerable<GaleryViewModel> GetAllPictures()
        {
            IEnumerable<Galery> galeries = Context.Galeries;
            IEnumerable<GaleryViewModel> model = Mapper.Map<IEnumerable<Galery>, IEnumerable<GaleryViewModel>>(galeries);
            return model;
        }

        public void AddPIcture(GaleryViewModel model)
        {
           
            Galery picture = Mapper.Map<GaleryViewModel, Galery>(model);          
            Context.Galeries.Add(picture);
            Context.SaveChanges();
        }

        public GaleryViewModel EditPicture(int? id)
        {
            Galery galery = Context.Galeries.Find(id);
            GaleryViewModel model = Mapper.Map<Galery, GaleryViewModel>(galery);
            return model;
        }

        public void EditPic(GaleryViewModel pictureVm)
        {
            Galery galery = Mapper.Map<GaleryViewModel, Galery>(pictureVm);
            Context.Entry(galery).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public GaleryViewModel DeletePicture(int? id)
        {
            Galery galery = Context.Galeries.Find(id);
            GaleryViewModel model = Mapper.Map<Galery, GaleryViewModel>(galery);
            return model;
        }

        public void Delete(int? id)
        {
            Galery entityToDelete = Context.Galeries.Find(id);
            Context.Galeries.Remove(entityToDelete);
            Context.SaveChanges();
        }

        public IEnumerable<VideoVm> GetAllVideos()
        {
            IEnumerable<Video> videos = Context.Videos;
            IEnumerable<VideoVm> model = Mapper.Map<IEnumerable<Video>, IEnumerable<VideoVm>>(videos);
            return model;
        }

        public void AddVideo(VideoVm model)
        {
            Video video = Mapper.Map<VideoVm, Video>(model);
            Context.Videos.Add(video);
            Context.SaveChanges();
        }

        public VideoVm EditVideo(int? id)
        {
            Video video = Context.Videos.Find(id);
            VideoVm model = Mapper.Map<Video, VideoVm>(video);
            return model;
        }

        public void EditVid(VideoVm videoVm)
        {
            Video video = Mapper.Map<VideoVm, Video>(videoVm);
            Context.Entry(video).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public VideoVm DeleteVideo(int? id)
        {
            Video video = Context.Videos.Find(id);
            VideoVm model = Mapper.Map<Video, VideoVm>(video);
            return model;
        }

        public void DeleteVid(int? id)
        {
            Video entityToDelete = Context.Videos.Find(id);
            Context.Videos.Remove(entityToDelete);
            Context.SaveChanges();
        }
    }
}
