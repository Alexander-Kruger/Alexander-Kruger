const params = new URLSearchParams(window.location.search);
const genre = params.get("genre")

const galleryImages = {
    event: [
    {
        image: "assets/images/events/event001.jpg",
        title: "Wedding Photo",
        photographer: "Ethan Brannigan",
        client: "John and Lisa Doe",
        date: "19 February 2026"
    },
    {
        image: "assets/images/events/event002.jpeg",
        title: "Catering Service",
        photographer: "Devon Okafor",
        client: "Meridian Forge(Inc.)",
        date: "28 March 2026"
    },
    {
        image: "assets/images/events/event003.jpeg",
        title: "Party Photo",
        photographer: "Marcus Tan",
        client: "Cobalt & Wren(LLC)",
        date: "30 April 2026"
    },
    {
        image: "assets/images/events/event004.jpeg",
        title: "Wedding Photo",
        photographer: "Simone Bexley",
        client: "Aria and Julian Hartley",
        date: "22 May 2026"
    },
    {
        image: "assets/images/events/event005.jpeg",
        title: "Toasting Photo",
        photographer: "Iris Vandermeer",
        client: "Northlight Dynamics",
        date: "2 July 2026"
    }
],

executive: [
    {
        image: "assets/images/executive/exec001.jpeg",
        title: "Executive Portrait",
        photographer: "Nadia Ferreira",
        client: "Ashgrove Analytics",
        date: "12 January 2026"
    },
    {
        image: "assets/images/executive/exec002.jpeg",
        title: "Executive Portrait",
        photographer: "Owen Kastellan",
        client: "Pinnacle & Vale",
        date: "3 February 2026"
    },
    {
        image: "assets/images/executive/exec003.jpeg",
        title: "Executive Portrait",
        photographer: "Bianca Whitlock",
        client: "Lumen Industries",
        date: "19 March 2026"
    },
    {
        image: "assets/images/executive/exec004.jpeg",
        title: "Executive Portrait",
        photographer: "Theo Marchetti",
        client: "Redstone Ventures",
        date: "7 April 2026"
    },
    {
        image: "assets/images/executive/exec005.jpeg",
        title: "Executive Portrait",
        photographer: "Sasha Reinholt",
        client: "Quillfeather Media",
        date: "17 January 2026"
    },
    {
        image: "assets/images/executive/exec006.jpeg",
        title: "Executive Portrait",
        photographer: "Camille Osei",
        client: "Ironbridge Logistics",
        date: "8 may 2026"
    },
    {
        image: "assets/images/executive/exec007.jpeg",
        title: "Executive Portrait",
        photographer: "Dmitri Volkov",
        client: "Solace Biotech",
        date: "16 August 2026"
    }
],

individual: [
    {
        image: "assets/images/individual/indi001.jpeg",
        title: "Executive Portrait",
        photographer: "Mateo Salvi",
        client: "Freya Adalstein",
        date: "22 March 2026"
    },
    {
        image: "assets/images/individual/indi002.jpeg",
        title: "Executive Portrait",
        photographer: "Rowan Blackwood",
        client: "Nia Fontenot",
        date: "12 February 2026"
    },
    {
        image: "assets/images/individual/indi003.jpeg",
        title: "Executive Portrait",
        photographer: "Sophie Lindqvist",
        client: "Jasper Ondieki",
        date: "8 April 2026"
    },
    {
        image: "assets/images/individual/indi004.jpeg",
        title: "Executive Portrait",
        photographer: "Kian Osei",
        client: "Tobias Renner",
        date: "29 May 2026"
    },
    {
        image: "assets/images/individual/indi005.jpeg",
        title: "Executive Portrait",
        photographer: "Elena Castellano",
        client: "Lucia Barrington",
        date: "11 July 2026"
    }
],

product: [
    {
        image: "assets/images/product/prod001.jpeg",
        title: "Donuts",
        photographer: "Vivienne Castellan",
        client: "Cascade & Thorn",
        date: "6 April 2026"
    },
    {
        image: "assets/images/product/prod002.jpeg",
        title: "Product Photography",
        photographer: "Felix Obiora",
        client: "Silverlark Studios",
        date: "24 November 2026"
    },
    {
        image: "assets/images/product/prod003.jpeg",
        title: "Product Photography",
        photographer: "Priya Nakamura",
        client: "Brightwell Systems",
        date: "13 May 2026"
    },
    {
        image: "assets/images/product/prod004.jpeg",
        title: "Product Photography",
        photographer: "Yara Delgado",
        client: "Vantage Bio",
        date: "2 June2026"
    },
    {
        image: "assets/images/product/prod005.jpeg",
        title: "Product Photography",
        photographer: "Callum Ashworth",
        client: "Emberline Media",
        date: "18 January 2026"
    },
    {
        image: "assets/images/product/prod006.jpeg",
        title: "Product Photography",
        photographer: "Isabela Marchetti",
        client: "Copperfield Logistics",
        date: "3 July 2026"
    },
    {
        image: "assets/images/product/prod007.jpeg",
        title: "Product Photography",
        photographer: "Soren Kallberg",
        client: "Nova Ridge Capital",
        date: "26 August 2026"
    }
],

architecture: [
     {
        image: "assets/images/architecture/arc_001.jpeg",
        title: "A building",
        photographer: "Talia Marchetti",
        client: "Meridian Foundry",
        date: "9 January 2026"
    },
    {
        image: "assets/images/architecture/arc_002.jpeg",
        title: "A building",
        photographer: "Anders Voss",
        client: "Kestrel Dynamics",
        date: "24 march 2026"
    },
    {
        image: "assets/images/architecture/arc_003.jpeg",
        title: "A building",
        photographer: "Layla Whitfield",
        client: "Brasswind Media",
        date: "15 January 2026"
    },
    {
        image: "assets/images/architecture/arc_004.jpeg",
        title: "A building",
        photographer: "Ravi Chandran",
        client: "Red River Construction",
        date: "24 April2026"
    },
    {
        image: "assets/images/architecture/arc_005.jpeg",
        title: "A building",
        photographer: "Esme Doran",
        client: "Fernwood Analytics",
        date: "19 febuary 2026"
    },
    {
        image: "assets/images/architecture/arc_006.jpeg",
        title: "A building",
        photographer: "Kofi Adeyemi",
        client: "Harborlight Groupn",
        date: "30 January 2026"
    }

],

nature: [
    {
        image: "assets/images/nature/nat001.jpeg",
        title: "Flower Field",
        photographer: "Zara Ibrahimović",
        client: "Personal",
        date: "9 January 2026"
    },
    {
        image: "assets/images/nature/nat002.jpeg",
        title: "Branch with River",
        photographer: "Lena Katsaros",
        client: "Personal",
        date: "28 February 2026"
    },
    {
        image: "assets/images/nature/nat003.jpeg",
        title: "Three Birdies",
        photographer: "Beckett Hollowell",
        client: "Personal",
        date: "15 March 2026"
    },
    {
        image: "assets/images/nature/nat004.jpeg",
        title: "Peacefully Drinking",
        photographer: "Nikolai Braithwaite",
        client: "Personal",
        date: "21 April 2026"
    },
    {
        image: "assets/images/nature/nat005.jpeg",
        title: "Attacking Birdie",
        photographer: "Clara Vinter",
        client: "Personal",
        date: "6 May 2026"
    },
    {
        image: "assets/images/nature/nat006.jpeg",
        title: "Yes, i do see you",
        photographer: "John Smith",
        client: "Personal",
        date: "17 June 2026"
    },
    {
        image: "assets/images/nature/nat007.jpeg",
        title: "What a nice day",
        photographer: "Dashiell Moreau",
        client: "Personal",
        date: "2 August 2026"
    }
]
};

const galleryContainer = document.getElementById("gallery-container");

const images = galleryImages[genre];

images.forEach(function(photo) {

    const article = document.createElement("article");

    const img = document.createElement("img");
    img.src = photo.image;
    img.alt = photo.title;

    const overlay = document.createElement("div");
    overlay.classList.add("overlay");

    const title = document.createElement("h1");
    title.textContent = photo.title;

    const photographer = document.createElement("h2");
    photographer.textContent = photo.photographer;

    const client = document.createElement("h3");
    client.textContent = photo.client;

    const date = document.createElement("h5");
    date.textContent = photo.date;

    overlay.appendChild(title);
    overlay.appendChild(photographer);
    overlay.appendChild(client);
    overlay.appendChild(date);

    article.appendChild(img);
    article.appendChild(overlay);

    galleryContainer.appendChild(article);
});