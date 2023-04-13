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

///* slider */
//var slides = document.querySelectorAll(".slide");
//var dots = document.querySelectorAll(".dot");
//var index = 0;

//function prevSlide(n) {
//    index += n;
//    console.log("prevSlide is called");
//    changeSlide();
//}

//function nextSlide(n) {
//    index += n;
//    changeSlide();
//}

//changeSlide();

//function changeSlide() {
//    if (index > slides.length - 1) index = 0;

//    if (index < 0) index = slides.length - 1;

//    for (let i = 0; i < slides.length; i++) {
//        slides[i].style.display = "none";

//        dots[i].classList.remove("active");
//    }

//    slides[index].style.display = "block";
//    dots[index].classList.add("active");
//}
///* slider-end */
