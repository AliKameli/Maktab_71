var hoverTimes = 1;

// console.log();
function addHoverCount(a) {
    hoverTimes += 1;
    console.log(a)
};
function reposition(item) {
    item.style.marginTop = (100 * hoverTimes) + "px"
    item.style.marginLeft = (60 * hoverTimes) + "px"
};