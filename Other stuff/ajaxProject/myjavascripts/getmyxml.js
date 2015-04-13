function loadXMLDoc(url)
{
    var xmlhttp;
    var txt,x,xx,i;
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
            txt="<table border='2'><tr><th>Nafn</th><th>Netfang</th><th>Gsm</th><th>Heimilisfang</th></tr>";
            x=xmlhttp.responseXML.documentElement.getElementsByTagName("Person");
            for (i=0;i<x.length;i++)
            {
                txt=txt + "<tr>";
                xx=x[i].getElementsByTagName("Name");
                {
                    try
                    {
              
                        txt=txt + "<td>" + xx[0].firstChild.nodeValue + "</td>";
                    }
                    catch (er)
                    {
                        txt=txt + "<td> </td>";
                    }
                }
                xx=x[i].getElementsByTagName("Email");
                {
                    try
                    {
                        txt=txt + "<td>" + xx[0].firstChild.nodeValue + "</td>";
                    }
                    catch (er)
                    {
                        txt=txt + "<td> </td>";
                    }
                }
      
                xx=x[i].getElementsByTagName("Gsm");
                {
                    try
                    {
                        txt=txt + "<td>" + xx[0].firstChild.nodeValue + "</td>";
                    }
                    catch (er)
                    {
                        txt=txt + "<td> </td>";
                    }
                }
      
                xx=x[i].getElementsByTagName("Address");
                {
                    try
                    {
                        txt=txt + "<td>" + xx[0].firstChild.nodeValue + "</td>";
                    }
                    catch (er)
                    {
                        txt=txt + "<td> </td>";
                    }
                }
                txt=txt + "</tr>";
            }
        }
        txt=txt + "</table>";
        document.getElementById('txtXmlInfo').innerHTML=txt;
    }
    
    xmlhttp.open("GET",url,true);
    xmlhttp.send();
}
function clearText(){
    document.getElementById('txtXmlInfo').innerHTML="";
    alert("Hvert fór taflan???? :-(");
}
function getmysqltext()
{
    alert("Hvert fór taflan???? :-(");
//
//    if (window.XMLHttpRequest)
//    {// code for IE7+, Firefox, Chrome, Opera, Safari
//        xmlhttp=new XMLHttpRequest();
//    }
//    else
//    {// code for IE6, IE5
//        xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
//    }
//    xmlhttp.onreadystatechange=function()
//    {
//        if (xmlhttp.readyState==4 && xmlhttp.status==200)
//        {
//            document.getElementById("txtSqlInfo").innerHTML=xmlhttp.responseText;
//        }
//    }
//  
//    xmlhttp.open("GET","mysqltext.php?",true);
//    xmlhttp.send();
}

