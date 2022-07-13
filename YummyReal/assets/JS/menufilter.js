let menuItem = document.querySelectorAll(".filter-item");

menuItem.forEach((item) =>
  item.addEventListener("click", function () {
    menuItem.forEach((item) => {
      item.classList.remove("active");
    });
    this.classList.add("active");
  })
);
