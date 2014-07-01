var masterAjax = function (method, url, data, callback) {
    var request = new XMLHttpRequest();
    request.open(method, url);
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            if (this.response =! "") {
                var data = JSON.parse(this.response);
                callback(data);
            }
            else{
                callback();
            }
        }
        else {
            console.log("Error " + this.response);
        }
    }
    request.onerror = function () {
        console.log("Connection Error");
    };
    if (data) {
        request.send(JSON.stringify(data));
    }
    else {
        request.send();
    }
};

var totalQuestions = 0;
var currentQuestion = 0;
var correctAnswer = 0;
var score = 0;

var startQuiz = function () {
    masterAjax("GET", "/api/Question/-1", null, function (data) {
        totalQuestions = data.QuestionCount;
        currentQuestion = 1;
        getQuestion();
    })
};

var getQuestion = function () {
    masterAjax("GET", "/api/Question/" + currentQuestion, null, function (data) {
        document.getElementById("prompt").innerHTML = data.Prompt;
        document.getElementById("a1").innerHTML = data.Answer1;
        document.getElementById("a2").innerHTML = data.Answer2;
        document.getElementById("a3").innerHTML = data.Answer3;
        document.getElementById("a4").innerHTML = data.Answer4;
        correctAnswer = data.correctAnswer;
    })
};

var checkAnswer = function () {
    var selected;
    for (var i in document.getElementsByName("answer")) {
        if (document.getElementsByName("answer")[i].checked) {
            selected = document.getElementsByName("answer")[i].value;
        }
    }
    if (selected == correctAnswer) {
        alert("correct!");
        score++;
    }
    else {
        alert("incorrect!");
    }
    currentQuestion++;
    getQuestion();
};