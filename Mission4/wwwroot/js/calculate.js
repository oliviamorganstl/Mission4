$("#btnsend").click(function () { //This section calculates the weights for different grade categories
    var grade = (parseInt($("#assign").val()) * 0.5);
    grade += (parseInt($("#proj").val()) * 0.1);
    grade += (parseInt($("#quiz").val()) * 0.1);
    grade += (parseInt($("#mid").val()) * 0.1);
    grade += (parseInt($("#fin").val()) * 0.1);
    grade += (parseInt($("#intex").val()) * 0.1);

    var letterGrade;

    //Loop through to see what the letter grade is
    if (grade >= 90) {
        letterGrade = 'A';
    }
    else if (grade >= 80) {
        letterGrade = 'B';
    }
    else if (grade >= 70) {
        letterGrade = 'C';
    }
    else if (grade >= 60) {
        letterGrade = 'D';
    }
    else if (grade <= 60) {
        letterGrade = 'Failing'
    }

    alert("Your class grade is a " + String(grade) + "%. Your letter grade is " + letterGrade + "."); //Alert out the results
})