function getmysqltext()
{

    if (window.XMLHttpRequest)
    {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp=new XMLHttpRequest();
    }
    else
    {// code for IE6, IE5
        xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange=function()
    {
        if (xmlhttp.readyState==4 && xmlhttp.status==200)
        {
            document.getElementById("txtSqlInfo").innerHTML=xmlhttp.responseText;
        }
    }
  
    xmlhttp.open("GET","mysqltext.php?",true);
    xmlhttp.send();
}
function clearsql(){
    document.getElementById("txtSqlInfo").innerHTML="";
    alert("Hvert fóru sql gögnin ???? :-(");
}