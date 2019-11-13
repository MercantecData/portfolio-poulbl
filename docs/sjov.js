
var isRunning = false;
function testKlik()
{
    document.getElementById("testKnap").innerHTML = "Paragraph changed.";
}

function sleep(seconds)
{
  var e = new Date().getTime() + (seconds * 1000);
  while (new Date().getTime() <= e) {}
}

function showFeedbackForm()
{
  var form = document.getElementById('form');
  form.style.visibility = 'visible';
}

function submitFeedbackForm()
{
    var text = document.getElementById('feedbackText').value;
    var form = document.getElementById('form');

    form.style.visibility = 'hidden';
    document.getElementById('feedbackPost').innerHTML = "Din Feedback: "+text;
    showSnackbar();
}

function toggleDude()
{
    var img = document.getElementById('funkyGIF');

    if (img.style.visibility === 'visible') {
    //  img.style.visibility = 'hidden';
    } else {
      img.style.visibility = 'visible';
    }

    document.getElementById("testKnap").innerHTML = "GANG I DEN!!!";
    triggered();
    funkTion(false);
}

function getRandomParrot()
{
  var path = 'parrots/hd/',
      imgs = ['partyparrot.gif','fastparrot.gif','evilparrot.gif', 'angelparrot.gif', 'angryparrot.gif', 'beerparrot.gif', 'bikerparrot.gif', 'birthdaypartyparrot.gif', 'bluntparrot.gif', 'bootlegparrot.gif', 'bouncingparrot.gif', 'beretparrot.gif', 'bunnyparrot.gif', 'ceilingparrot.gif', 'chicoparrot.gif'
    , 'christmasparrot.gif', 'confusedparrot.gif', 'congaparrot.gif', 'copparrot.gif', 'dadparrot.gif', 'darkmodeparrot.gif', 'dealwithitnowparrot.gif', 'dealwithitparrot.gif', 'discoparrot.gif', 'donutparrot.gif', 'flowerparrot.gif', 'flyingmoneyparrot.gif', 'frenchparrot.gif', 'gentlemanparrot.gif'
    , 'githubparrot.gif', 'gothparrot.gif'];
      i = Math.floor(Math.random()*imgs.length);
      document.getElementById("parrot").src = path+imgs[i];
}


function funkTion(shouldRun)
{
 if(shouldRun)
{
  document.getElementById("body").style.background = randomColor();
  document.getElementById("main-nav").style.background = randomColor();
  document.getElementById("header1").style.color = getRandomColor();
  document.getElementById("p1").style.color = randomColor();
  document.getElementById("p2").style.color = randomColor();
  document.getElementById("p3").style.color = randomColor();
  document.getElementById("p4").style.color = randomColor();
  document.getElementById("p5").style.color = randomColor();
  document.getElementById("h2").style.color = randomColor();
  document.getElementById("h3").style.color = randomColor();
  document.getElementById("ul").style.background = randomColor();
  isRunning = true;
  var millisecondsToWait = 1000;
  setTimeout(function() {
      funkTion(true);
    }, millisecondsToWait);
    console.log(body.style.background);
}
  else {
    if(!isRunning)
    {
      funkTion(true);
    }
  }
}

function triggered()
{
  var isVisible = document.getElementById("testKnap").innerHTML;

  if(isVisible=="GANG I DEN!!!")
  {
    getRandomParrot();
  }
  else {
  }

}

function randomColor()
{
  return '#'+(Math.random()*0xFFFFFF<<0).toString(16);
}



function showSnackbar() {
  // Get the snackbar DIV
  var snack = document.getElementById("snackbar");

  // Add the "show" class to DIV
  snack.className = "show";

  // After 3 seconds, remove the show class from DIV
  setTimeout(function(){ snack.className = snack.className.replace("show", ""); }, 3000);
}















function getRandomColor()
{
  let rand = Math.random();
  {
  if(rand > 0.9)
  {
    return 'red';
  }
  else if (rand > 0.8) {
    return 'blue';
  }
  else if (rand > 0.7) {
    return 'pink';
  }
  else if (rand > 0.6) {
    return 'cyan';
  }
  else if (rand > 0.5) {
    return 'yellow';
  }
  else if (rand > 0.4) {
   return 'green';
  }
  else if (rand > 0.3) {
    return 'orange';
  }
  else if (rand > 0.2) {
    return 'purple';
  }
  else if (rand > 0.1) {
    return '#6B6A6A';
  }
  else  {
    return '#FFFFFFF';
  }
}
}
