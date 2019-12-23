using AutoMapper;

namespace BlogBL.BLModels
{
    public static class Mapping<TBL, KDAL> where TBL : class where KDAL : class
    {
        public static IMapper _blMapper = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<TBL, KDAL>();
                cfg.CreateMap<KDAL, TBL>();
            }).CreateMapper();
        public static KDAL FromBlToDal(TBL article)
        {
            return _blMapper.Map<TBL, KDAL>(article);
        }
        public static TBL FromDalToBl(KDAL article)
        {
            return _blMapper.Map<KDAL, TBL>(article);
        }
    }
}
