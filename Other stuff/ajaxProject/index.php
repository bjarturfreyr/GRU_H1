<html>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <script type="text/javascript" src="./myjavascripts/getmytext.js"></script>
    <script type="text/javascript" src="./myjavascripts/getmyxml.js"></script>
    <script type="text/javascript" src="./myjavascripts/getmysql.js"></script>

    <body>
        <div align="center">
            <div id="container" style="width:500px">

                <div id="header" style="background-color:#FFA5FF;">
                    <h1 style="margin-bottom:0;">Titill síðu</h1></div>

                <div id="menu" style="background-color:#FFD7FF;height:500px;width:100px;float:left;">
                    <b>Valmynd</b><br />
                    HTML<br />
                    CSS<br />
                    JavaScript<br />
                    AJAX<br />
                    <button onclick="clearText()">Láta töflu hverfa</button><br/>
                    <button onclick="getmysqltext()">Birta sql</button><br/>
                    <button onclick="clearsql()">Láta sql gögn hverfa</button><br/>


                </div>

                <div align="justify" id="content" style="background-color:#EEEEFF;height:500px;width:400px;float:left;">
                    Texti kemur hér þegar valið er viðfangsefni án þess að síðan endurhlaðist.</div>


                <div id="footer" style="background-color:#FFA5FF;clear:both;text-align:center;">Upplýsingatækniskólinn Eiríkur Benediktsson</div>

            </div>
            <label style=" color: red">Flokka eftir viðfangsefni</label><br>
            <select name="users" onchange="gettext(this.value)">
                <option value="1">Nýjustu fréttir:</option>
                <option value="2">Mót framundan:</option>
                <option value="3">Nýjustu úrslit</option>
            </select>
            <button onclick="loadXMLDoc('./docs/myfirstxml.xml')">Sækja xml skrá</button>
            <div id="txtXmlInfo"></div>
            <div id="txtSqlInfo"></div>

    </body>
</html>
