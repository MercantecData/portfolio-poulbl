

function testKlik()
{
    document.getElementById("testKnap").innerHTML = "Paragraph changed.";
}

function sleep(seconds)
{
  var e = new Date().getTime() + (seconds * 1000);
  while (new Date().getTime() <= e) {}
}

function funkTion()
{
  document.getElementById("body").style.background = getRandomColor();
  document.getElementById("main-nav").style.background = getRandomColor();
  document.getElementById("header1").style.color = getRandomColor();
  document.getElementById("p1").style.color = getRandomColor();
  document.getElementById("p2").style.color = getRandomColor();
  document.getElementById("p3").style.color = getRandomColor();
  document.getElementById("p4").style.color = getRandomColor();
  document.getElementById("h2").style.color = getRandomColor();
  document.getElementById("h3").style.color = getRandomColor();
  document.getElementById("ul").style.color = getRandomColor();


    console.log(body.style.background);
    var millisecondsToWait = 5000;
    setTimeout(function() {
      funkTion();
    }, millisecondsToWait);
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
