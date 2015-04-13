<!DOCTYPE html>
<html lang="en">
<head>
<?php 
include 'PHP/Includes/dbcon.php';
?>
<meta charset="utf-8"> <!--ísl stafir -->
<meta http-equiv="X-UA-Compatible" content="IE=edge"><!--compatible með I-explorer -->
<meta name="viewport" content="width=device-width, initial-scale=1"><!--Lætur widthið á síðunni vera jafn mikið og á deviceinu sem að maður er á/responsive stuff -->
<link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
<link rel="stylesheet" href="bootstrap/css/bootstrap.css">
<link rel="stylesheet" href="css/mainsitecss.css">


	<title>Gankr</title>

<!--navbar-->
<nav class="navbar navbar-default navbar-top" role="navigation">
      
  <div class="container-fluid">  

    <div class="navbar-header">
    
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
        
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      
      <a class="glyphicon glyphicon-home" style="color:#3e4162" href="file://tsuts/GRU_H1/Main%20Site/index.html.php#"></a>

    </div>
    
    <div class="collapse h navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
      <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown">&nbsp&nbspPlaceholder<span class="caret"></span></a>
          <ul class="dropdown-menu"  role="menu">
            <li><a href="#">Placeholder&nbsp&nbsp</a></li>
            <li class="divider"></li>
            <li><a href="#">Placeholder&nbsp&nbsp</a></li>
            <li class="divider"></li>
            <li><a href="#">Placeholder&nbsp&nbsp</a></li>
            <li class="divider"></li>
            <li><a href="#">Placeholder&nbsp&nbsp</a></li>
          </ul>
        </li>
        <li><a href="#">Placeholder</a></li>
        <li><a href="#">Placeholder</a></li>
      </ul>
      <ul class="nav navbar-nav lr pull-right">
      <li><a href="#" data-toggle="modal" data-target="#loginregister">Login/Register</a></li>
      </ul>

      <!--search div-->
      <form class="navbar-form leita pull-right" role="search"><!--Addaði pull-right-->
        <div class="form-group">
          <input type="text" class="form-control" placeholder="Leita">  
                <a class="glyphicon glyphicon-search" style="color:#3e4162"  href="placeholder.html"></a><!--search idcon-->        
        </div>       

      </form><!--search div-->
 <form class="navbar-form leita2 pull-right" role="search"><!--Addaði pull-right-->
        <div class="form-group">
          <input type="text" class="form-control" placeholder="Leita">                          
        </div>       
      </form>
    </div><!-- navbar -->
  </div><!-- container -->
</nav>

<!--Login/Register form Modal -->
<div class="modal fade bs-example-modal-md" id="loginregister" tabindex="-1" role="dialog" aria-labelledby="myMediumModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-md">
    <div class="modal-content">
    <div class="form">
      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">Sign Up</a></li>
        <li class="tab"><a href="#login">Log In</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1 class = "loginregisterh1">Sign Up for Free</h1>
          
          <form action="/" method="post">
          
          <div class="top-row">
            <div class="field-wrap">
              <label>
                First Name<span class="req">*</span>
              </label>
              <input type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label>
                Last Name<span class="req">*</span>
              </label>
              <input type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Set A Password<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>

          <div class="field-wrap">
            <label>
              Confirm Password<span class="req">*</span>
            </label>
            <input type="confirm_password"required autocomplete="off"/>
          </div>
          
          <button type="submit" class="button button-block"/>Get Started</button>
          
          </form>

        </div>
        
        <div id="login">   
          <h1 class = "loginregisterh1">Welcome Back!</h1>
          
          <form action="/" method="post">
          
            <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Password<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>
          
          <p class="forgot"><a href="#">Forgot Password?</a></p>
          
          <button class="button button-block"/>Log In</button>
          
          </form>

        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->

    </div>
  </div>
</div>
</head>
<body>
<div class="wrap">

<div class="row">
      <div class="col-xs-12 col-sm-4 col-md-4 col-lg-3 col-lg-push-2">
          <div class="row">
          <div class="posts">
          <h3 align="center">3 most popular posts</h3>
          <div class="post1">         
                aslkhdkj asgdiug askhgdkjah sdljkas hdkljash dkjlh askdjlask
                ljdh klsajd hkjla hsdkjsah dkjs hadkj hasdkjh asdkjhaskjld h
                kalsjhdlkjashd kljas hdkjlash dkjlash dkjash dkjhas dkjh ask
                jdh aksjdh kjasd hkjashd kjash djklashd kjlahs djksha dkjahs
                .a,js bdkjlash gdkjlahs dasjhd kjash djsa         
          </div>
          <div class="post2">
                aslkhdkj asgdiug askhgdkjah sdljkas hdkljash dkjlh askdjlask
                ljdh klsajd hkjla hsdkjsah dkjs hadkj hasdkjh asdkjhaskjld h
                kalsjhdlkjashd kljas hdkjlash dkjlash dkjash dkjhas dkjh ask
                jdh aksjdh kjasd hkjashd kjash djklashd kjlahs djksha dkjahs
                .a,js bdkjlash gdkjlahs dasjhd kjash djsa         
          </div>
          <div class="post3">
                aslkhdkj asgdiug askhgdkjah sdljkas hdkljash dkjlh ask
                laskljdh klsajd hkjla hsdkjsah dkjs hadkj hasdkjh asdkjhas
                ld hkalsjhdlkjashd kljas hdkjlash dkjlash dkjash dkjhas dkjh
                 askjdh aksjdh kjasd hkjashd kjash djklashd kjlahs djksha dk
                 jahs.a,js bdkjlash gdkjlahs dasjhd kjash djsa         
          </div>                         
          </div>
        </div>
  </div>
  <div class="col-xs-12 col-sm-8 col-md-8 col-lg-5 col-lg-push-2">
            
          <div class="blogs">          
<?php

    try {

        $stmt = $db->query('SELECT blogs.BlogID, blogs.BlogTitle, blogs.BlogDesc, blogs.BlogDate, users.Username FROM users_has_blogs
        INNER JOIN blogs ON users_has_blogs.Blogs_BlogID = blogs.BlogID INNER JOIN
        users on users_has_blogs.Users_UserID = users.UserID ORDER BY blogs.BlogID DESC LIMIT 8');
        while($row = $stmt->fetch()){
            
            echo '<div>';
                echo '<h1><a href="PHP/ViewPost.html.php?id='.$row['BlogID'].'">'.$row['BlogTitle'].'</a></h1>';?>
                <a class="glyphicon glyphicon-thumbs-up pull-left" style="color:green"  href="placeholder.html">
                <a class="glyphicon glyphicon-thumbs-down pull-left" style="color:red"  href="placeholder.html"></a><?php
                echo '<p>&nbsp&nbspPosted by '.'<a>'.$row['Username'].'</a>'.' on '.date('jS M Y H:i:s', strtotime($row['BlogDate'])).'</p>';
                echo '<p>'.$row['BlogDesc'].'</p>';                
                echo '<p><a href="PHP/ViewPost.html.php?id='.$row['BlogID'].'">Read More</a></p>';                
            echo '</div>';

        }

    } catch(PDOException $e) {
        echo $e->getMessage();
    }
?>

        </div> 
  </div>
</div>
</div>

 <footer class="footer">
      <div class="container">
        <p class="text-muted">Place sticky footer content here placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder.</p>
      </div>
    </footer> 
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
<script src="bootstrap/js/bootstrap.min.js"></script>
<script>
$('.form').find('input, textarea').on('keyup blur focus', function (e) {
  
  var $this = $(this),
      label = $this.prev('label');

    if (e.type === 'keyup') {
      if ($this.val() === '') {
          label.removeClass('active highlight');
        } else {
          label.addClass('active highlight');
        }
    } else if (e.type === 'blur') {
      if( $this.val() === '' ) {
        label.removeClass('active highlight'); 
      } else {
        label.removeClass('highlight');   
      }   
    } else if (e.type === 'focus') {
      
      if( $this.val() === '' ) {
        label.removeClass('highlight'); 
      } 
      else if( $this.val() !== '' ) {
        label.addClass('highlight');
      }
    }

});

$('.tab a').on('click', function (e) {
  
  e.preventDefault();
  
  $(this).parent().addClass('active');
  $(this).parent().siblings().removeClass('active');
  
  target = $(this).attr('href');

  $('.tab-content > div').not(target).hide();
  
  $(target).fadeIn(600);
  
});
</script>
<!--End JS script -->
</body>


</html>