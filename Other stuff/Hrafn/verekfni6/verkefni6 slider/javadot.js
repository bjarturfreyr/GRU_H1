$('.sliderinn').each(function() {// vel sliderinn div daginn og for loopar fyrir hvert eitt og einasta
  var $this   = $(this);// bý til breytu sem að er þessi slide sem að ég er á í loopuni
  var $group  = $this.find('.myndir');// næ í divið sem að heldur um myndirnar
  var $sidur = $this.find('.slide');// geri það sama tek current slide mynd og set í tag
  var takkafylki  = [];//bý til fykli fyrir takkana
  var nuverandimynd = 0;// breyta til að geyma númer á þeirri mynd sem er verið að sýna(1-4)
  var timi;// breyta til að stjórna tíma seinna
  function move(nymynd) { // þessi function býr til nýja slide
    var hreyfavinstri, slidavinstri;//breytur sem að þarf að nota
    advance();// When slide moves, call advance() again!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // passa að ekkert er gert ef það er á current slide
    if ($group.is(':animated') || nuverandimynd === nymynd) {  
      return;
    }

    takkafylki[nuverandimynd].removeClass('active'); //taka í burtu active klassann
    takkafylki[nymynd].addClass('active');  //setja klasann á nýja takkann

    if (nymynd > nuverandimynd) {   //ef að næsta mynd er með meira gildi en hin
      slidavinstri = '100%';            //setja myndina til hægri
      hreyfavinstri = '-100%';         //færa myndina inn til vinstri
    } else {                         //annars ef að það er komið að seinustu myndinni
      slidavinstri = '-100%';           //set upphafsmyndir vinsta meiginn
      hreyfavinstri = '100%';          //læt upphafs mynd dragast í hægri átt
    }
    // koma nýjum slidum fyrir
    $sidur.eq(nymynd).css( {left: slidavinstri, display: 'block'} );
    $group.animate( {left: hreyfavinstri}, function() {// keyra animate á myndir
      $sidur.eq(nuverandimynd).css( {display: 'none'} );// fela myndina sem var áður stillt á    
      $sidur.eq(nymynd).css( {left: 0} );// setja stöðuna á nýjumyndinni með því að breyta cssinu
      $group.css( {left: 0} ); // setja stöðuna öllum myndur með því að breyta cssinu
      nuverandimynd = nymynd; // nær í nýja mynd
    });
  }

  function advance() {// function til að stilla tíma
    clearTimeout(timi); // hreinsa breytuna
    timi = setTimeout(function() {// setja nýjann tíma á
      if (nuverandimynd < ($sidur.length - 1)) { //ef myndin er númerum meira en heildar fjöldi mynda
        move(nuverandimynd + 1);// fara á næstu mynd
      } else {// annars
        move(0);// fara á fyrstu myndina
      }
    }, 3000);// skipta á 3 sekúnda fresti
  }

  $.each($sidur, function(index) {// fyrir hverja slide bý ég til takka
    var $button = $('<button type="button" class="slide-btn">&bull;</button>');
    if (index === nuverandimynd) {    // ef að það komin ný mynd
      $button.addClass('active');    // þá kemur nýr takki
    }
    $button.on('click', function() { // Þegar ýtt er á takkann
      move(index);                   // fer hún í move functionið og setur gildið index í hana
    }).appendTo('.slide-buttons');   // Add to the buttons holder
    takkafylki.push($button);       // setur takkann í array
  });

  advance();// keyra functionið


});