

function filter_list() {
    let inp = document.querySelector('#modal_search_box');
    let list = document.querySelector('.list .list-group').querySelectorAll('li');
    let re = new RegExp(inp.value, 'i');
    list.forEach((x) => {
        if (re.test(x.textContent)) {
            x.innerHTML = x.textContent.replace(re, '<b>$&</b>');
            x.style.display = 'block';
        } else {
            x.style.display = 'none';
        }
    });
}


function filter_list_kisi() {
    let inp_kisi = document.querySelector('#modal_search_box_kisi');
    let list_kisi = document.querySelector('#list_kisi #list_grup_kisi').querySelectorAll('li');
    let re = new RegExp(inp_kisi.value, 'i');
    list_kisi.forEach((x) => {
        if (re.test(x.textContent)) {
            x.innerHTML = x.textContent.replace(re, '<b>$&</b>');
            x.style.display = 'block';
        } else {
            x.style.display = 'none';
        }
    });
}
