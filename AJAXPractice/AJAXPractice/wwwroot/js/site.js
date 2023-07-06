function SaveStudent() {
    //get all selected radio button. In our case we gave same name to radio button
    //so only one radio button will be selected either Male or Female
    var selected = $("input[type='radio'][name='Gender']:checked");
    let formData = {
        studentId: $("#StudentId").val(),
        studentName: $("#StudentName").val(),
        standard: $("#StudentStd").val(),
        city: $("#StudentCity").val(),
        isRegular: $("#IsRegular").is(":checked"),
        gender: selected.length > 0 ? selected.val() : 0,
    }
    console.log(formData)
    $.ajax({
        url: "/Home/SaveStudentWithoutSerialize",
        type: "POST",
        data: formData,
        success: function (response) {
            alert(response);
        },
        error: function (request, status, error) {
            alert(request.responseText);
        }
    });
}