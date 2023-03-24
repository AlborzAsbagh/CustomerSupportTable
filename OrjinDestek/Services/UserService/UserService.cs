using OrjinDestek.Models;

namespace OrjinDestek.Services.UserService;

public class UserService:IUsuerService
{
    private TbCrmUser _user = null!;
        
    public TbCrmUser Getuser()
    {
        return _user;
    }

    public void SetUser(TbCrmUser user)
    {
        _user = user;
    }
}