$(function (e) {
    var calendar = $("#calendar").calendarGC({
        dayBegin: 1,
        prevIcon: '&#x3c;',
        nextIcon: '&#x3e;',
        onPrevMonth: function (e) {
            console.log("prev");
            console.log(e)
        },
        onNextMonth: function (e) {
            console.log("next");
            console.log(e)
        },
        events: [
            {
                date: new Date('2022-11-28 20:15:00 GMT+3'),
                eventName: "Holiday",
                className: "badge bg-danger",
                onclick(e, data) {
                    console.log(data);
                },
                dateColor: "red"
            },
            {
                date: new Date("2022-11-29"),
                eventName: "Holiday with wife",
                className: "badge bg-danger",
                onclick(e, data) {
                    console.log(data);
                },
                dateColor: "red"
            },
            {
                date: new Date("2022-11-30"),
                eventName: "Working day",
                className: "badge bg-success",
                onclick(e, data) {
                    console.log(data);
                },
                dateColor: "green"
            }
        ],
        onclickDate: function (e, data) {
            console.log(e, data);
        }
    });
})