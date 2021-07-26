:root {
  --ff-body: "Montserrat", sans-serif;
  --ff-heading: "Poppins", sans-serif;
  --fw-normal: 400;
  --fw-semibold: 700;
  --fw-bold: 900;
  --clr-primary-200: #e3f4ff;
  --clr-primary-300: #8c9af9;
  --clr-primary-400: #0059ff;
  --clr-light: #fff;
}

::selection {
  color: var(--clr-primary-200);
  background-color: var(--clr-primary-400);
}

html {
  scroll-behavior: smooth;
}

body {
  margin: 0;
  font-family: var(--ff-body);
  font-weight: var(--fw-normal);
  line-height: 1.6;
  font-size: clamp(1rem, 5vw, 1rem);
  overflow-x: hidden;
  text-align: center;
}

h1,
h2,
h3 {
  font-family: var(--ff-heading);
}

h1 {
  font-size: clamp(3rem, 8vw, 3.8rem);
  line-height: 0.9;
}

h3 {
  font-weight: var(--fw-semibold);
}

.big-heading {
  font-weight: var(--fw-bold);
}

.sub-heading {
  font-size: clamp(1.1rem, 8vw, 1.4rem);
  font-weight: var(--fw-normal);
  line-height: 1;
}

.signature {
  font-size: clamp(1.5rem, 8vw, 2rem);
  margin-bottom: 2rem;
  margin-top: 0;
}

a:focus {
  outline: dotted 2px var(--clr-primary-400);
}



.container {
  display: grid;
  width: 100vw;
  height: 100vh;
  margin: 0px auto;
  grid-template-columns: 1fr;
  grid-template-rows: 1fr 2fr 1fr;
  grid-gap: 0;
}

.header {
 background-color: var(--clr-primary-200);
 padding: 3% 5%;
 text-align: right;

 align-items: right;
}

.content {
  background-color: var(--clr-primary-200);
  color: var(--clr-primary-300);
}

.footer {
  background-color: #fff;
  color: var(--clr-primary-400);
}

// ICONS and LOGO

.heart-icon {
  margin: 2rem;
  color: #8c9af9;
}

.footer-icon {
  margin: 2rem;
  padding-bottom: 10px;
  color: #0059ff;
}

.footer-icon:hover {
  color: #8c9af9;
}

.logo {
  width: min(50vw, 140px);
}

