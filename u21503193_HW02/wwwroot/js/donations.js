$(document).ready(function () {

    document.getElementById("SelectedFullName").addEventListener("change", function () {
        var selectedFullName = this.value;

        var phoneNumberDropdown = document.getElementById("SelectedPhoneNumber");

        phoneNumberDropdown.innerHTML = "";

        if (selectedFullName) {
            var selectedOption = document.querySelector(`[value="${selectedFullName}"]`);
            if (selectedOption) {
                var phoneNumber = selectedOption.getAttribute("data-phonenumber");

                var newOption = document.createElement("option");
                newOption.value = phoneNumber;
                newOption.text = phoneNumber;

                phoneNumberDropdown.appendChild(newOption);

                console.log("Selected Phone Number: " + phoneNumber);
            }
        } else {
            var defaultOption = document.createElement("option");
            defaultOption.value = "";
            defaultOption.text = "Select a Phone Number";
            phoneNumberDropdown.appendChild(defaultOption);
        }
    });


    //goal amount 
    var goalAmount = ViewBag.GoalAmount;

    //total amount raised
    var totalAmountRaised = ViewBag.TotalAmountRaised;

    if (totalAmountRaised >= goalAmount) {
        var goalReachedElement = document.getElementById("goalReachedMessage");
        goalReachedElement.innerHTML = "Goal Reached!";
        goalReachedElement.style.color = "green";
    }
});
