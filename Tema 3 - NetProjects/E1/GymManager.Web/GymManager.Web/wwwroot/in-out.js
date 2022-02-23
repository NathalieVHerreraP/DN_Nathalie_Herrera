document.addEventListener("DOMContentLoaded", function () {

    //BTN, Keyup and stuff idk

    var memberID = document.getElementById("IDMember");
    memberID.addEventListener("keyup", function (evt) {
        if (evt.keyCode === 13) {
            document.getElementById("memberbtn").click();
        }
    });

    var action = document.getElementById("action").value;

    var modalMember = new bootstrap.Modal(document.getElementById("membersModal"));

    document.getElementById("memberbtn").addEventListener("click", onClickKeyupAction);

    debugger;

    //functions

    function onClickKeyupAction() {

        var tableMember = document.getElementById('memebersActions');

        var ID = memberID.value;

        if (action = "in") {

            tableMember.innerHTML = "<tr> <td>IN</td> <td>" + ID + "</td><td>" + moment(new Date()).format("DD-MM-YYYY HH:mm:ss") + "</td></tr>";

        } else {

            tableMember.innerHTML = "<tr> <td>OUT/td> <td>" + ID + "</td><td>" + moment(new Date()).format("DD-MM-YYYY HH:mm:ss") + "</td></tr>";

        }

        modalMember.show();

    }

   
});




