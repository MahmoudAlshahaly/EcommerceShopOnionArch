/* rating stars and form review */
let selectedStars = document.getElementById("rate");
/* let form = document.getElementById("form");

let starts = 0;
const star1 = document
    .getElementById("1")
    .addEventListener("click", (target) => {
        selectedStars.value = target.target.id;
    });
const star2 = document
    .getElementById("2")
    .addEventListener("click", (target) => {
        selectedStars.value = target.target.id;
    });
const star3 = document
    .getElementById("3")
    .addEventListener("click", (target) => {
        selectedStars.value = target.target.id;
    });
const star4 = document
    .getElementById("4")
    .addEventListener("click", (target) => {
        selectedStars.value = target.target.id;
    });
const star5 = document
    .getElementById("5")
    .addEventListener("click", (target) => {
        selectedStars.value = target.target.id;
    }); */

/* rating stars and form review-end */
const star = document.querySelector("#stars");
const stars = document.querySelectorAll("#stars a");
stars.forEach((star, clickIdx) => {
    star.classList.add("disabled");
    star.addEventListener("click", () => {
        stars.forEach((otherStar, otherIdx) => {
            if (otherIdx <= clickIdx) {
                otherStar.classList.add("active");
            }
        });
        //console.log(clickIdx);
        stars.forEach((otherStar, otherIdx) => {
            if (otherIdx > clickIdx) {
                otherStar.classList.remove("active");
            }
        });
        selectedStars.value = clickIdx + 1;
        console.log(selectedStars.value);
    });
});
/* swap images */
const mainImage = document.getElementById("mainImage");

const imgBtns = [
    document.querySelector(".smallImageBtn-1"),
    document.querySelector(".smallImageBtn-2"),
    document.querySelector(".smallImageBtn-3"),
    document.querySelector(".smallImageBtn-4"),
];
imgBtns.forEach((imgBtn) => {
    imgBtn.addEventListener("click", (e) => {
        mainImage.src = e.target.src;
    });
});
const imgWrapper = document.getElementById("imgWrapper");
let prevButton = null;

imgWrapper.addEventListener("click", (e) => {
    const selectedImage = e.target.nodeName === "IMG";

    if (!selectedImage) {
        return;
    }

    e.target.classList.add("border-primary");

    if (prevButton !== null) {
        prevButton.classList.remove("border-primary");
    }

    prevButton = e.target;
});
/* swap images-end */

/*  */
/* tailwind configuration */
tailwind.config = {
    theme: {
        screens: {
            sm: "500px",
            md: "768px",
            lg: "992px",
            xl: "1200",
        },
        container: { center: true, padding: "1rem" },
        extend: {
            fontFamily: {
                poppins: "'Poppins',sans-serif",
                roboto: "'Roboto',sans-serif",
            },
            colors: { primary: "#FD3D57" },
        },
    },

    variant: {
        extend: {
            display: ["group-hover"],
            visibility: ["group-hover"],
        },
    },
};

/* tailwind configuration-end */

