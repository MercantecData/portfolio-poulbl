

function testKlik()
{
    document.getElementById("testKnap").innerHTML = "Paragraph changed.";
}


function funkTion()
{
  let rand = Math.random();
  if(rand > 0.9)
  {
    document.getElementById("body").style.background = 'red';
  }
  else if (rand > 0.8) {
    document.getElementById("body").style.background = 'blue';
  }
  else if (rand > 0.7) {
    document.getElementById("body").style.background = 'pink';
  }
  else if (rand > 0.6) {
    document.getElementById("body").style.background = 'cyan';
  }
  else if (rand > 0.5) {
    document.getElementById("body").style.background = 'yellow';
  }
  else if (rand > 0.4) {
    document.getElementById("body").style.background = 'green';
  }
  else if (rand > 0.3) {
    document.getElementById("body").style.background = 'orange';
  }
  else if (rand > 0.2) {
    document.getElementById("body").style.background = 'purple';
  }
  else if (rand > 0.1) {
    document.getElementById("body").style.background = '#6B6A6A';
  }
  else if (rand > 0.0) {
    document.getElementById("body").style.background = '#FFFFFFF';
  }
}
