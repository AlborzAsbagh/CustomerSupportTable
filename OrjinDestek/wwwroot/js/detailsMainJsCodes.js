
const addMail = document.getElementById('add_mail');
const inputMail = document.getElementById('email_input');
const innerDivMail = document.getElementById('mail_tabs_menu');
const rvzBilgisiHidden = document.getElementById('rvzBilgisi');
const proje = document.querySelector("#Proje");
const rvzSelector = document.querySelector("#RevizyonBilgisi");
const rvzCheckBox = document.querySelector("#rvzCheckBox");

const option = document.createElement('option');
option.value = rvzBilgisiHidden.value;
option.text = rvzBilgisiHidden.value;
rvzSelector.appendChild(option);

let mailsArray = [];
let mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

addMail.addEventListener('click',function() {
    
    if(inputMail && inputMail.value) {
        if(inputMail.value.match(mailformat)) {
            let newElement = 
                `<span onclick="remove(this);" class="mail_tab_span">${inputMail.value}<span class="delete_button">X</span></span>`;
            innerDivMail.innerHTML += newElement;
            mailsArray.push(inputMail.value);
            inputMail.value = "";
            
        } else {
            alert("Lütfen geçerli bir e-mail hesabı giriniz.")
        }
    } else {
        alert("Lütfen göndermek istediğiniz kişinin e-mail hesabını giriniz.")
    }
    
});

rvzCheckBox.addEventListener('change',function () {
    if(this.checked) {
        rvzSelector.disabled = false;
        $.ajax( {
            url:'AddRecord/GetRevizyonBilgileri/',
            dataType:'json',
            data:{projeAdi:proje.value},
            type:'GET',
            success:function (data) {
                if(data !== "false") {
                    rvzSelector.innerHTML = '';
                    data.forEach( function (element) {
                        const option = document.createElement('option');
                        option.value = element;
                        option.text = element;
                        rvzSelector.appendChild(option);
                    });
                    rvzBilgisiHidden.value = rvzSelector.value;
                }else {
                    alert("Revizyon bilgileri alınırken hata oluştu");
                }
            },
            error:function (data) {
                alert("Revizyon bilgilerine erişmedi");
            }
        });
        getRvzBilgileri();
    }else {
        rvzBilgisiHidden.value = rvzSelector.value;
        rvzSelector.disabled = true;
    }
});

rvzSelector.addEventListener('change',function () {
    rvzBilgisiHidden.value = rvzSelector.value;
})

function getRvzBilgileri() {
    proje.addEventListener('change',function (event) {
        if(!rvzSelector.disabled) {
            $.ajax( {
                url:'AddRecord/GetRevizyonBilgileri/',
                dataType:'json',
                data:{projeAdi:event.target.value},
                type:'GET',
                success:function (data) {
                    if(data !== "false") {
                        rvzSelector.innerHTML = '';
                        data.forEach( function (element) {
                            const option = document.createElement('option');
                            option.value = element;
                            option.text = element;
                            rvzSelector.appendChild(option);
                        });
                    }else {
                        alert("Revizyon bilgileri alınırken hata oluştu");
                    }
                },
                error:function (data) {
                    alert("Revizyon bilgilerine erişmedi");
                }
            });
        }
    });
}

function remove(element) {
    let str = element.textContent;
    let newStr = str.substring(0,str.length - 1);
    let indexToRemove = mailsArray.indexOf(newStr);
    element.style.display = 'none';
    if(indexToRemove > -1) {
        mailsArray.splice(indexToRemove,1);
    }
}

function toggleSelectAll(element) {
    const checked = element.checked
    const options = document.querySelectorAll(".yapilan_islem_bottom_container_1 .option-link input")

    if (checked) {
        options.forEach((option) => {
            if (!mailsArray.includes(option.value)) {
                mailsArray.push(option.value)
            }
        })
    } else {
        options.forEach((option) => {
            mailsArray = mailsArray.filter((mail) => mail !== option.value)
        })
    }
}

function toggle(element) {
    const checked = element.checked
    const mail = element.value
    
    if (checked) {
        mailsArray.push(mail)
    } else {
        mailsArray = mailsArray.filter((m) => m !== mail)
    }
}

$("#comment-form").submit(function(e) {
    e.preventDefault();

    // Get the form data
    let action = document.getElementById('action').value;
    let konu = document.getElementById('Konu').value;
    let refNo = document.getElementById('refNo').value;
    let userName = document.getElementById('user').value;
    mailsArray.forEach(function (element) {
       console.log(element); 
    })
    if(action !== "") {
        // Submit the form data using AJAX
        $.ajax({
            url:"/DetailsPage/AddNewAction/",
            type:"POST",
            traditional: true,
            data:{action:action,refNo:refNo,mailsArray:mailsArray,konu:konu},
            dataType: "json",
            success: function(data){
                if(data !== "flase") {
                    let dateTime = new Date($.now());
                    const innerDivAction = document.getElementById('yapilan_islem');
                    let newElement = `<div class="card mb-4">
                <div class="card-body card-style">
                <div class="d-flex justify-content-between" style="margin:10px 0 0 10px">
                <div class="d-flex flex-row align-items-center">
                <img src="img/user.png" alt="avatar" width="25" height="25" />
                <span id="action_span" class="small mb-0 ms-2" style="margin-left: 10px"><b>${userName}</b> /
                ${dateTime.getDate()+"."+(dateTime.getMonth()+1)+"."+dateTime.getFullYear()+" / "+dateTime.getHours()+"."+dateTime.getMinutes() + "." + dateTime.getSeconds()}</span>
                </div>
                </div>
                <p class="card_paragraph" style="margin-top: 10px">${action}</p>
                </div>`;
                    innerDivAction.innerHTML += newElement;
                    document.getElementById('action').value = "";
                    if(mailsArray.length !== 0 ){
                        cuteAlert({
                            type: "success",
                            title: "Başarılı",
                            message: "Mesajınız başarılı bir şekilde iletildi.",
                            buttonText: "Tamam",
                        });
                    }
                } else {
                    cuteAlert({
                        type: "error",
                        title: "Hata",
                        message: "Mesajınız başarılı bir şekilde iletilmedi.",
                        buttonText: "Tamam",
                    })
                }
            } ,
            error: function(data) {
                cuteAlert({
                    type: "error",
                    title: "Hata",
                    message: "Bağlantı hatası",
                    buttonText: "Tamam",
                })
            }
        });
    } else {
        alert("Lütfen yapılan işlemi girin");
    }
});

function getUserInfo(name) {
    $.ajax( {
        url:'DetailsPage/GetUserInfo/',
        data:{name:name.textContent},
        dataType:'json',
        type:'GET',
        success: function (data) {
            if(data === "False") alert("Kullanıcının telefon numarası ve email hesabına eişmedi");
            else {
                document.getElementById('TalepEden').value = name.textContent;
                document.getElementById('EmailHesabi').value = data.userMail;
                document.getElementById('userEmail').value = data.userMail;
                document.getElementById('TelNo').value = data.userTelNo;
                document.getElementById('userTelNo').value = data.userTelNo;
                
            }
            $("#gorusulenKisiModal").modal('hide')
        },
        error: function () {
            alert("Bağlantı hatası");
        }
    })
}





