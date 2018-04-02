import {bindable, inject} from 'aurelia-framework';

@inject(Element)
export class PagerCustomElement {
  @bindable page;
  @bindable totalPages;

  constructor(element) {
    this.element = element;
  }

  totalPagesChanged() {
    let pages = [];

    for (let i = 1; i <= this.totalPages; i++) {
      pages.push(i);
    }

    this.pages = pages;
  }

  goToNextPage() {
    if (this.page < this.totalPages) {
      this.onPageChanged(this.page + 1);
    }
  }

  goToPage(page) {
    if (this.page !== page) {
      this.onPageChanged(page);
    }
  }

  goToPreviousPage() {
    if (this.page > 1) {
      this.onPageChanged(this.page - 1);
    }
  }

  onPageChanged(page) {
    let changeEvent;

    if (window.CustomEvent) {
      changeEvent = new CustomEvent('change', {
        detail: { page: page },
        bubbles: true
      });
    } else {
      changeEvent = document.createEvent('CustomEvent');
      changeEvent.initCustomEvent('change', true, true, { page: page });
    }
    this.element.dispatchEvent(changeEvent);
  }
}
