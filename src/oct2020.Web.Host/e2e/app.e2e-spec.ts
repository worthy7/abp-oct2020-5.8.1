import { oct2020TemplatePage } from './app.po';

describe('oct2020 App', function() {
  let page: oct2020TemplatePage;

  beforeEach(() => {
    page = new oct2020TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
