using Spring.Net.Models;

namespace Spring.Net
{
    public interface IUserInfoDal
    {
        UserInfo UserInfo { get; set; }
        string Name { get; set; }

        void Show();
    }
}