using BlogBL.BLModels;
using BlogDAL.Repository;

namespace BlogBL.Service
{
    public abstract class GenericService<BLModel, DModel> : IGenericService<BLModel>
        where BLModel : class
        where DModel : class
    {
        private readonly IGenericRepository<DModel> _repository;
        public GenericService()
        {
            _repository = new GenericRepository<DModel>();
        }
        public virtual BLModel FindById(int id)
        {
            var entity = _repository.FindById(id);
            return Mapping<BLModel, DModel>.FromDalToBl(entity);
        }
    }
}
