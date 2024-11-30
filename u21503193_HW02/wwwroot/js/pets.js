$(document).ready(function () {
    var initialPetsList = $("#petsList").html();

    var $typeDropdown = $("#typeDropdown");
    var $breedDropdown = $("#breedDropdown");

    var typeToBreeds = {
        "Dog": ["Labrador", "Golden Retriever", "Dachshund"],
        "Cat": ["Persian", "Siamese", "Ragdoll"],
        "Bird": ["Cockatiel", "Tippler", "Harz Roller"]
    };

    function updateBreedDropdown() {
        var selectedType = $typeDropdown.val();
        var breeds = typeToBreeds[selectedType] || [];

        $breedDropdown.empty();

        breeds.forEach(function (breed) {
            $breedDropdown.append($('<option>', {
                value: breed,
                text: breed
            }));
        });
    }

    $typeDropdown.on("change", function () {
        updateBreedDropdown();
    });

    updateBreedDropdown();

    $("#searchButton").click(function () {
        var selectedType = $typeDropdown.val();
        var selectedBreed = $breedDropdown.val();
        var selectedLocation = $("#locationDropdown").val();

        filterPets(selectedType, selectedBreed, selectedLocation);
    });

    $("#clearButton").click(function () {
        $typeDropdown.val("");
        $breedDropdown.val("");
        $("#locationDropdown").val("");

        $("#petsList").html(initialPetsList);
    });

    function filterPets(type, breed, location) {
        $(".pet-list-item").each(function () {
            var $petItem = $(this);

            var petType = $petItem.data("pet-type");
            var petBreed = $petItem.data("pet-breed");
            var petLocation = $petItem.data("pet-location");

            var typeMatch = type === "" || petType === type;
            var breedMatch = breed === "" || petBreed === breed;
            var locationMatch = location === "" || petLocation === location;

            console.log("Selected Type: " + type);
            console.log("Selected Breed: " + breed);
            console.log("Selected Location: " + location);

            if (typeMatch && breedMatch && locationMatch) {
                $petItem.show();
            } else {
                $petItem.hide();
            }
        });
    }
});
