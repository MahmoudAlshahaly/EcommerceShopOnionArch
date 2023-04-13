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
