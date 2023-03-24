using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbMail
{
    public int TbMailId { get; set; }

    public string? MailKonu { get; set; }

    public string? MailAciklama { get; set; }

    public int? MailTip { get; set; }
}
