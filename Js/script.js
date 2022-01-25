//  (function(){ 
{let updateContentFunc = function updateContentFunc(flag){
    let url = 'https://www.cbr-xml-daily.ru/daily_json.js';
    let begin=`<div class="card">
    <div class="title"><h3>`

    let body=`</div>
    <div>`;
    let image=`<img src="https://flagcdn.com/224x168/`;
    let imageEnd = `.png"
    width="224"
    height="168">
    </div>
    </div>`;
    let content = '';
if(flag===true){
    fetch(url)
    .then((response) =>{
        return response.json();
    }).then((response) => {
        let str = JSON.stringify(response.Valute);       
        localStorage['content']= str;
        Object.values(response.Valute).forEach( (res) =>{
            let name = res.Name;
            let charCode = res.CharCode;
            let value = res.Value;
            let nominal = res.Nominal;
            let code = res.CharCode.substring(0,2).toLowerCase();
            content+= `<div class="card">
            <div class="title">
                 <h3>${name} (${charCode})</h3>
                 <p>Цена: ${value}</p>
            </div>
            <div>
             <img class="img-result"
             src="https://flagcdn.com/224x168/${code}.png"
             width="224"
             height="168"
             alt="South Africa">
            </div>
         </div>`
        })
        document.getElementsByClassName('cards')[0].innerHTML =content;  
    }).then(() =>{
        let preloader = document.getElementById('preloader');
        preloader.style.display='none';
        localStorage['updateTime']= +new Date() + (2*3600 * 1000);
    })}
    else
    {
         let response= JSON.parse(localStorage['content']);
        new Promise((r,req) => 
        {
            Object.values(response).forEach(res => {
                let name = res.Name;
                let charCode = res.CharCode;
                let value = res.Value;
                let nominal = res.Nominal;
                let code = res.CharCode.substring(0,2).toLowerCase();
                content+= `<div class="card">
                <div class="title">
                     <h3>${name} (${charCode})</h3>
                     <p>Цена: ${value}</p>
                </div>
                <div>
                 <img class="img-result"
                 src="https://flagcdn.com/224x168/${code}.png"
                 width="224"
                 height="168"
                 alt="South Africa">
                </div>
                </div>`
            });
            document.getElementsByClassName('cards')[0].innerHTML =content;
            let preloader = document.getElementById('preloader');
            preloader.style.display='none';
    }).then((content)=>{
           
        } )}
    }
if(localStorage.getItem('content') === null){
     updateContentFunc(true);    
}else{
    const updateTime = localStorage.getItem('updateTime');
    if (updateTime !== null) 
    {
        if (+new Date() >= parseInt(updateTime)) 
        {
            localStorage.removeItem('updateTime');
            updateContentFunc(true);
        }
        else{
            updateContentFunc(false);
        }
    }
    else
    {
        updateContentFunc(true);
    }
    
}

const updateButton = document.querySelector('.update');
updateButton.addEventListener('click', function () {
    document.getElementsByClassName('cards')[0].innerHTML ='';
    let preloader = document.getElementById('preloader');
            preloader.style.display='block';
            updateContentFunc(true);
  });
}
// }());