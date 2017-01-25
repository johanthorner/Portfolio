$(document)
      .ready(function () {

          var colorList = [];

          function hexToRgb(hex) {
              var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
              return result ? {
                  r: parseInt(result[1], 16),
                  g: parseInt(result[2], 16),
                  b: parseInt(result[3], 16)
              } : null;
          }
          $('.carousel-item')
              .each(function (index, item) {

                  var colorValue = hexToRgb($(item).data('color'));
                  var transparencyValue = $(item).data('transparency');
                  var colorValueAndTransarency = colorValue.r + "," + colorValue.g + "," + colorValue.b + ", " + transparencyValue;

                  $(item).addClass('tint');
                  $(item)
                      .mouseenter(function () {
                          var css = '.tint:hover:before {background: rgba(' + colorValueAndTransarency + ');}';
                          var lastCss;

                          head = document.head || document.getElementsByTagName('head')[0],
                          style = document.createElement('style');

                          style.type = 'text/css';
                          if (style.styleSheet) {
                              style.styleSheet.cssText = css;
                          } else {
                              style.appendChild(document.createTextNode(css));

                          }
                          head.appendChild(style);
                          $(item).addClass('tint:hover:before');
                          $(this).find('h3').show();

                          lastCss = css;

                      }).mouseleave(function () {
                          $(this).find('h3').hide();
                      });
              });


      });