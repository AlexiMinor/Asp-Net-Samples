export interface Article {
  id:string;
  title: string;
  category: string;
  shortSummary: string;
  text: string;
  publicationDate: Date;
  rate: number;
  sourceId: string;
  sourceUrl: string;
}
