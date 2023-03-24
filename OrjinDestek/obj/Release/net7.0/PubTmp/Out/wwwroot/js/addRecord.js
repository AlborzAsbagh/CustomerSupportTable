
const proje = document.querySelector("#Proje");
const rvzSelector = document.querySelector("#RevizyonBilgisi");
const rvzCheckBox = document.querySelector("#rvzCheckBox");

function validateForm() {
    let firma = document.forms["addRecordForm"]["Firma"].value;
    let gorusulenKisi = document.forms["addRecordForm"]["TalepEden"].value;
    let proje = document.forms["addRecordForm"]["Proje"].value;
    let konu = document.forms["addRecordForm"]["Konu"].value;
    let aciklama = document.forms["addRecordForm"]["Aciklama"].value;
    let destekTipi = document.forms["addRecordForm"]["DestekTipi"].value;
    let rvzBilgisi = document.forms["addRecordForm"]["RevizyonBilgisi"].value;
    let rvzCheckBoxValue = document.getElementById('rvzCheckBox').checked;
    
    if(rvzCheckBoxValue) {
        if ( (firma === "") || (gorusulenKisi === "") ||  (proje === "") || (konu === "")
            || (aciklama === "") || (destekTipi) === "") {

            if(firma === "") document.getElementById('Firma').style.borderColor = 'red';
            if(gorusulenKisi === "") document.getElementById('TalepEden').style.borderColor = 'red';
            if(proje === "") document.getElementById('Proje').style.borderColor = 'red';
            if(konu === "") document.getElementById('Konu').style.borderColor = 'red';
            if(aciklama === "") document.getElementById('Aciklama').style.borderColor = 'red';
            if(destekTipi === "") document.getElementById('DestekTipi').style.borderColor = 'red';
            if(rvzBilgisi === "") document.getElementById('RevizyonBilgisi').style.borderColor = 'red';
            event.preventDefault();

        }
    } else {
        if ( (firma === "") || (gorusulenKisi === "") ||  (proje === "") || (konu === "")
            || (aciklama === "") || (destekTipi) === "") {

            if(firma === "") document.getElementById('Firma').style.borderColor = 'red';
            if(gorusulenKisi === "") document.getElementById('TalepEden').style.borderColor = 'red';
            if(proje === "") document.getElementById('Proje').style.borderColor = 'red';
            if(konu === "") document.getElementById('Konu').style.borderColor = 'red';
            if(aciklama === "") document.getElementById('Aciklama').style.borderColor = 'red';
            if(destekTipi === "") document.getElementById('DestekTipi').style.borderColor = 'red';
            event.preventDefault();

        }
    }
    
}

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
        rvzSelector.innerHTML = "";
        rvzSelector.disabled = true;
    }
});

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

function getGorusulenKisi(name) {
    document.getElementById('Firma').value = name.textContent;
    let innerDiv = document.getElementById('list_grup_kisi');
    $.ajax({
        url:'AddRecord/GetGorusulenKisilerListe/',
        data:{firmaAdi:name.textContent},
        dataType: 'json',
        type:'GET',
        success:function (data) {
            innerDiv.innerHTML = "";
            data.forEach(function (element) {
                let li = '<li class="list-group-item linked-li" onclick="getGorusulenKisiInfo(this)">'+element+'</li>';
                innerDiv.innerHTML+=li;
                innerDiv.inerrHTML = "";
            });
            $("#firmaModal").modal("hide")
        },
        error:function (){
            alert("Firma personeline kişilere erişemedi");
        }
    });
}

function getGorusulenKisiInfo(name) {
    document.getElementById('TalepEden').value = name.textContent;
    $.ajax({
        url:'AddRecord/GetKisiMail/',
        data:{kisiAdi:name.textContent},
        dataType: 'json',
        type:'GET',
        success:function (data) {
           document.getElementById('EmailHesabi').value = '';
           document.getElementById('EmailHesabi').value = data;
        },
        error:function (){
            alert("Kişinin email hesabına eişemedi ");
        }
    });

    $.ajax({
        url:'AddRecord/GetKisiTelefon/',
        data:{kisiAdi:name.textContent},
        dataType: 'json',
        type:'GET',
        success:function (data) {
            document.getElementById('TelNo').value = '';
            document.getElementById('TelNo').value = data;
            $("#gorusulenKisiModal").modal("hide")
        },
        error:function (){
            alert("Kişinin telefon numarasına eişemedi ");
        }
    });
}

