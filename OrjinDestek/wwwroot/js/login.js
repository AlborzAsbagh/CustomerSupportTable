
function getUser() {
    event.preventDefault();
    
    let userNo = document.getElementById("UserCode").value;
    let userPassword = document.getElementById("UserPassword").value;
    
    if(userNo ==="" || userPassword === "") {
        alert("Lütfen şifre ve kullanıcı numaranızı giriniz");
    }
    
    else {
        $.ajax( {
            url:"Login/GetTheUser/",
            data:{userNo:userNo , userPassword:userPassword},
            dataType:'json',
            type:'GET',
            success:function (data) {
                if(data === "False") {
                    cuteAlert({
                        type: "error",
                        title: "Hata",
                        message: "Kullanıcı bulunamadı",
                        buttonText: "Tamam",
                    });
                } else {
                    localStorage.setItem('token',data);
                    window.location.href = '/Home?token='+localStorage.getItem('token');
                }
            },
            error:function (data) {
                cuteAlert({
                    type: "error",
                    title: "Hata",
                    message: "Bağlantı hatası",
                    buttonText: "Tamam",
                });
            }
        })
    }
    
}
