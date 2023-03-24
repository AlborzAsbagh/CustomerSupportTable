using OrjinDestek.Models;

namespace OrjinDestek.Services.UserService;

public interface IUsuerService
{
    TbCrmUser Getuser();
    public void SetUser(TbCrmUser user);
}