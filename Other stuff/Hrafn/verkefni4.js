var ollItems = new Array(); //global fylki fyrir öll divin
  function init() {

      // Set öll div í fylki sem að eru spurninga div
      var divs = document.getElementsByTagName( 'div' );
      for ( var i = 0; i < divs.length; i++ ) {
        if ( divs[i].className == 'spurning' ) ollItems.push( divs[i] );
      }

      //setja event á þegar klikkað er á haus spurningar
      for ( var i = 0; i < ollItems.length; i++ ) {//fer í gegnum hverja spurningu
        var h2 = getFirstChildWithTagName( ollItems[i], 'H2' );//setur spurninguna í getFirstChildWithTagName function
        h2.onclick = toggleItem; //þegar ýtt er á hausinn á spurningu þá notast toggle functionið á breytuna
      }

      // Rúlla í gegnum öll item í flykinu ollItems og fel þau
      for ( var i = 0; i < ollItems.length; i++ ) {
        ollItems[i].className = 'spurning hide'; //gefur divinu nýtt css sem að með hide á og felur öll      
      }
    }

  function	toggleItem() {
  	var itemClass = this.parentNode.className; //býr til breytu fyrir valna spurningu

  	// lokar öllu þannig það lokar öðrum opnum spurningum ef ýtt er á eitthverja aðra
  	for (var i = 0; i < ollItems.length; i++) {
  		ollItems[i].className = "spurning hide";//það er óhætt að loka öllum hér því opna if setningin kemur á eftir því að öllum er lokað
    }
  	//Spyr valna spurninga divið hvort það sé falið, ef það er falið þá er það sýnt
  	if ( itemClass == 'spurning hide') {
  		this.parentNode.className = 'spurning';
      spurning.style.background = 'yellow';
  	}

  }

  function getFirstChildWithTagName( element, tagName ) { //hjálpa til með að velja rétta spurningu þegar ýtt er á spurningu
      for ( var i = 0; i < element.childNodes.length; i++ ) {
        if ( element.childNodes[i].nodeName == tagName ) return element.childNodes[i]; // returnar spurningunni sem að var ýtt á
      }
    }

    function batevidspurningu() {
        var aukaspurningin = document.getElementById("fname").value;
        if(aukaspurningin.length === 0) {
                alert("Þú verður að slá eitthvað inn");
                return;
        }
        document.getElementById("result").innerHTML = "You wrote " + aukaspurningin + ".";
}