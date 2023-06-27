using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReigns.Card
{
    public class Doctor     //의사
    {
        Random random = new Random();

        public void Conversation(ref string[] conversation)
        {
            int number = 9;

            switch (number)
            {
                case 0:
                    conversation[0] = "    저는 의술에 능통하며 연금술과   ";
                    conversation[1] = "       독약 지식도 있습니다.        ";
                    conversation[2] = "                                    ";
                    break;
                case 1:
                    conversation[0] = "  무기와 전술에 대한 새로운 실험에  ";
                    conversation[1] = "         착수하고자 합니다.         ";
                    conversation[2] = "        지원해 주시겠습니까?        ";
                    break;
                case 2:
                    conversation[0] = "    폐하는 통풍을 앓고 계십니다.    ";
                    conversation[1] = "   앞으로는 고기를 줄이고 야채를    ";
                    conversation[2] = " 많이 드시고 난봉질은 그만두십시오. ";
                    break;
                case 3:
                    conversation[0] = " 처녀의 피를빤 거머리로 만든 비장의 ";
                    conversation[1] = "      약입니다. 드시면 단번에       ";
                    conversation[2] = "         통풍이 낫습니다.           ";
                    break;
                case 4:
                    conversation[0] = " 설탕을 너무 많이 드셨습니다. 폐하! ";
                    conversation[1] = "       섭취량을 줄이지 않으면       ";
                    conversation[2] = "       생명에 지장이 있습니다.      ";
                    break;
                case 5:
                    conversation[0] = "    납을 황금으로 바꾸는 실험에     ";
                    conversation[1] = "        착수하고자 합니다.          ";
                    conversation[2] = "       지원해 주시겠습니까?         ";
                    break;
                case 6:
                    conversation[0] = "    실험 중 알코올을 효율적으로     ";
                    conversation[1] = "   증류하는 방법을 발견했습니다.    ";
                    conversation[2] = "  수익의 일부는 폐하에게도 드리지요 ";
                    break;
                case 7:
                    conversation[0] = "     비축해둔 호밀에 식중독균을     ";
                    conversation[1] = "    발견했습니다. 비축해둔 식량을   ";
                    conversation[2] = "         소각하시겠습니까?          ";
                    break;
                case 8:
                    conversation[0] = " 경하드립니다! 오늘은 폐하의 50번째 ";
                    conversation[1] = "           생신이십니다.            ";
                    conversation[2] = "                                    ";
                    break;
                case 9:
                    conversation[0] = "   이 성에서 서쪽의 과학자 동료를   ";
                    conversation[1] = "    모아 교류회를 열고 싶습니다.    ";
                    conversation[2] = "                                    ";
                    break;
            }
        }
    }
}
