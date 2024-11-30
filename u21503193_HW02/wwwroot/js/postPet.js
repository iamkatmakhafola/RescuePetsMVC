$(document).ready(function () {
    document.getElementById("SelectedUserFullName").addEventListener("change", function () {
        var selectedUserFullName = this.value;

        var phoneNumberDropdown = document.getElementById("SelectedUserPhoneNumber");

        phoneNumberDropdown.innerHTML = "";

        if (selectedUserFullName) {
            var selectedOption = document.querySelector(`[value="${selectedUserFullName}"]`);
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


    // Pet Breed
    $("#SelectedPetType").change(function () {
        var selectedType = $(this).val();
        var breedDropdown = $("#SelectedPetBreed");

        breedDropdown.empty();
        breedDropdown.append($('<option value="">Select a Pet Breed</option>'));

        if (selectedType === "Dog") {
            breedDropdown.append($('<option value="Labrador">Labrador</option>'));
            breedDropdown.append($('<option value="Golden Retriever">Golden Retriever</option>'));
            breedDropdown.append($('<option value="Dachshund">Dachshund</option>'));

        } else if (selectedType === "Cat") {
            breedDropdown.append($('<option value="Persian">Persian</option>'));
            breedDropdown.append($('<option value="Siamese">Siamese</option>'));
            breedDropdown.append($('<option value="Ragdoll">Ragdoll</option>'));

        } else if (selectedType === "Bird") {
            breedDropdown.append($('<option value="Cockatiel">Cockatiel</option>'));
            breedDropdown.append($('<option value="Tippler">Tippler</option>'));
            breedDropdown.append($('<option value="Harz Roller">Harz Roller</option>'));
        }
    });
})
